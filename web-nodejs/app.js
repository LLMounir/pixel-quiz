const express = require('express');
const path = require('path');
require('dotenv').config();

//init app
const app = express();

const mongoose = require('mongoose');
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

//Start server
app.listen(3000, function(){
    console.log('Server started on port 3000..')
});

