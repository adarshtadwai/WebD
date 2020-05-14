var express = require("express")
var app = express();

app.get("/", function(req, res){
    res.render("addy.ejs");
});

app.get("/fellto/:thing", function(req, res){
    var thing = req.params.thing;
    res.render("fell.ejs", {thingvar : thing});
});

app.listen(3000, function () {
    console.log("Staring server at port 3000");
});