var fs = require('fs');
var http = require('http');
var request = require('request');
var keepAlive = new http.Agent({keepAlive:true});
var contents = fs.readFileSync("city.list.us.json");
var jscon = JSON.stringify(contents);
var id = 0;
var request = "";
var jsonText;
var answer = "";
//this function creates the request based on the number given

