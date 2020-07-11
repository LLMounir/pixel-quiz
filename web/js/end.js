const saveScoreBtn = document.getElementById('saveScoreBtn');
const finalScore = document.getElementById('finalScore');
const mostRecentScore = localStorage.getItem('mostRecentScore');

const highScores = JSON.parse(localStorage.getItem('highScores')) || [];

const MAX_HIGH_SCORES = 5;

finalScore.innerText = mostRecentScore+' Points';

username = new Date().toLocaleString();

var from = document.referrer;
var fromBool = from.includes("game");

if (!(fromBool)){
    window.location.assign('../index.html');
}

const score = {
    score: mostRecentScore,
    name: username,
};
highScores.push(score);
highScores.sort((a, b) => b.score - a.score);
highScores.splice(5);

localStorage.setItem('highScores', JSON.stringify(highScores));