const express = require('express');
const app = express();

app.get('/', function (req, res) {
  res.sendFile('/homeScreen.html', { root: __dirname });
});

app.get('/homeScreen.html', function (req, res) {
  res.redirect('/');
});

app.get('/project.html', function (req, res) {
  res.redirect('/');
});

app.get('/my-project.html', function (req, res) {
  res.redirect('/');
});

app.get('/myproject.html', function (req, res) {
  res.sendFile('/');
});
app.listen(8080);

app.use(function (req, res) {
  res.send('404 not Found.');
});
