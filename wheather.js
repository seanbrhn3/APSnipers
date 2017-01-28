var XMLHttpRequest = require('xmlhttprequest').XMLHttpRequest;
var xhr = new XMLHttpRequest();
 xhr.open("GET","http://api.openweathermap.org/data/2.5/forecast/city?id=524901&APPID=7dd3cabf117ddc729b666e5b23c24676",false);

xhr.send();

console.log(xhr);
