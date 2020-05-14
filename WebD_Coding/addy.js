var express = require("express");
var app = express();


app.get("/", function(req, res){
    res.send("Hi There");
});

app.get("/bye", function(req, res){
    res.send("Bye");
});

app.get("/dog", function(req, res){
    console.log("Opening /dog!!");
    res.send("Boww!!");
});

app.get("/r/:subreddit", function(req, res){
    var subreddit = req.params.subreddit;
    res.send("Welcome" + subreddit);
});

app.get("*", function (req, res) {
    res.send("Open Properly");
});

app.listen(3000, function(){
    console.log("starting server");
});
