const express = require('express');
const path = require('path');
require('dotenv').config();
const mongoose = require('mongoose');
const bodyParser = require('body-parser');
var http = require('http');

//init app
const app = express();

var application_root = __dirname;
const uri = process.env.ATLAS_URI;
mongoose.connect(uri, { useNewUrlParser: true, useUnifiedTopology: true });
const db = mongoose.connection;


//Check for db errors
db.on('error', function(err){
    console.log(err);
});

db.once('open', () => {
    console.log("MongoDB database connection established successfully");
})

// Bring in models
let Article = require('./models/article');

//load view engine
app.set('views', path.join(application_root, 'views'));
app.set('view engine', 'pug');

// Body parse middleware
app.use(bodyParser.urlencoded({extended: false}))
app.use(bodyParser.json())

// set public folder
app.use(express.static(path.join(application_root, 'public')));

//Home Route
app.get('/',function(req, res){
    Article.find({}, function(err, articles){
        if(err){
            console.log(err);
        } else {
            res.render('index', {
                title: 'Articles',
                articles: articles
            });
        }
    });
});

// Get single Article
app.get('/article/:id', function(req, res){
    Article.findById(req.params.id, function(err, article){
        res.render('article', {
            article:article
        });
    });
});

// Edit Form Route
app.get('/article/edit/:id', function (req, res) {
    Article.findById(req.params.id, function (err, article) {
        res.render('edit_article', {
            title:'Edit Article',
            article: article
        });
    });
});

//Add Route
app.get('/articles/add', function(req, res){
    res.render('add_article', {
        title: 'Add Article'
    });
});

// Add Submit POST Route
app.post('/articles/add', function(req, res){
    let article = new Article();
    article.title = req.body.title;
    article.author = req.body.author;
    article.body = req.body.body;
    
    article.save(function(err){
        if(err){
            console.log(err);
            return
        } else {
            res.redirect('/');
        }
    });
});

// Update Submit POST Route
app.post('/articles/edit/:id', function (req, res) {
    let article = {};
    article.title = req.body.title;
    article.author = req.body.author;
    article.body = req.body.body;

    let query = {_id:req.params.id}

    Article.update(query, article, function (err) {
        if (err) {
            console.log(err);
            return
        } else {
            res.redirect('/');
        }
    });
});

//Start server
app.listen(3000, function(){
    console.log('Server started on port 3000..')
});
