var fs = require('fs');
var XMLHttpRequest = require('xmlhttprequest').XMLHttpRequest;
var xhr = new XMLHttpRequest();
xhr.open("GET","http://api.openweathermap.org/data/2.5/forecast/city?id=524901&APPID=7dd3cabf117ddc729b666e5b23c24676",false);
xhr.send();
var contents = fs.readFileSync("city.list.us.json");
var jscon = JSON.stringify(contents);
function grabState(state){
	if(jscon.name == state){
		console.log("this works!");
	}
}

console.log(grabState("Bel Air"));
