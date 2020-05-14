console.log("Hi world!");
var todo = new Array;
do {
    var inp = prompt("Enter your decision");
    if (inp == "new") {
        var s = prompt("enter a todo list");
        todo.push(s);
    }
    else if (inp == "list")
        console.log(todo);
    else
        break;
} while (1)
alert("quitting your app");