const saveScoreBtn = document.getElementById('saveScoreBtn');
const finalScore = document.getElementById('finalScore');
const mostRecentScore = localStorage.getItem('mostRecentScore');

const highScores = JSON.parse(localStorage.getItem('highScores')) || [];

const MAX_HIGH_SCORES = 5;

finalScore.innerText = mostRecentScore+' Points';

var today = new Date();
var date = today.getDate() + '-' + (today.getMonth() + 1) + '-' + today.getFullYear();
var time = today.getHours() + ":" + today.getMinutes() + ":" + today.getSeconds();
var username = date + ' ' + time + ' ';
console.log(username);


const score = {
    score: mostRecentScore,
    name: username,
};
highScores.push(score);
highScores.sort((a, b) => b.score - a.score);
highScores.splice(5);

localStorage.setItem('highScores', JSON.stringify(highScores));
