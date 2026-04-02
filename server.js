const express = require('express');
const app = express();

app.get ('/', (req,res)=>
{
    res.send("Welcome to my awesome app <br> Xin chào, tôi là Phát Đào");
});

app.listen(3000, function()
{
    console.log ("App listeningg on port 3000");
});