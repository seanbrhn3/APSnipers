var fs = require('fs');
var XMLHttpRequest = require('xmlhttprequest').XMLHttpRequest;
var xhr = new XMLHttpRequest();
var contents = fs.readFileSync("city.list.us.json");
var jscon = JSON.stringify(contents);
var id = "";
function grabState(state){
	for(cid in jscon){
		if(jscon.name == state){
			id = jscon[cid].id;
		}
	}
}

grabState("Jones Crossroads");

xhr.open("GET","http://api.openweathermap.org/data/2.5/forecast/city?" + id + "&APPID=7dd3cabf117ddc729b666e5b23c24676",false);
xhr.send();
