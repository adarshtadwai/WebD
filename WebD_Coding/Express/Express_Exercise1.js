//Loading Express
var express = require("express")    //expressFW is strored in object called express.
var app = express();

//Routes

/*
function sound(name){
    var res = "";
    if (name === "pig") res = "'Oink'";
    else if(name === "cow") res = "'Moo'";
    else if(name ==="cow")  res = "'Woof Woof!'";
    else res = "Invalid Sound";
    return res;
}
*/

app.get("/", function(req, res){
    res.send("Hi, Welcome");
});

app.get("/speak/:animal", function(req, res){
    var animal_name = req.params.animal.toLowerCase();
    var sounds = {
        pig : "Oink",
        cow : "Moo",
        dog : "Woof Woof!"
    }
    var sound = sounds[animal_name];
    res.send("The " + animal_name + " says " + /*sound(name)*/ sound);
});

app.get("/repeat/hello/:number", function(req, res){
    var n = req.params.number;
    var arr = "";
    for(var i=0;i<n;i++)    arr += (n + " ");
    res.send(arr);
});


app.get("*", function(req, res){
    res.send("Page Not Found!!");   //server should sent a response as 
});


//Listening Port

app.listen(3000, function(){
    console.log("Staring server at port 3000");
});