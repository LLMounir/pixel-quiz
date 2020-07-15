const express = require('express');
const path = require('path');
require('dotenv').config();
const mongoose = require('mongoose');
const bodyParser = require('body-parser');
//init app
const app = express();


const uri = process.env.ATLAS_URI;
mongoose.connect(uri, { useNewUrlParser: true, useCreationIndex: true, useUnifiedTopology: true });
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
app.set('views', path.join(__dirname, 'views'));
app.set('view engine', 'pug');

// Body parse middleware
app.use(bodyParser.urlencoded({extended: false}))
app.use(bodyParser.json())

// set public folder
app.use(express.static(path.join(__dirname, 'public')));

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

//Start server
app.listen(3000, function(){
    console.log('Server started on port 3000..')
});

