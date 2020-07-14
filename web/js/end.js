const username = document.getElementById('username');
const saveScoreBtn = document.getElementById('saveScoreBtn');
const finalScore = document.getElementById('finalScore');
const mostRecentScore = localStorage.getItem('mostRecentScore');
var highScores = {};

let updateHighscores = function(){
    console.log(highScores);
}

fetch("../assets/highscores.json")
    .then(function (resp) {
        return resp.json();
    })
    .then(function (data) {
        highScores = data;
        updateHighscores();
    });

finalScore.innerText = mostRecentScore+' Points';

username.addEventListener('keyup', () => {
    saveScoreBtn.disabled = !username.value;
});

var from = document.referrer;
var fromBool = from.includes("game");

//TODO:REMOVE COMMENTS
/*
if (!(fromBool)){
    window.location.assign('../index.html');
}
*/

saveHighScore = (e) => {
    console.log(highScores);
    e.preventDefault();

    const score = {
        score: mostRecentScore,
        name: username.value,
    };
    highScores.push(score);
    highScores.sort((a, b) => b.score - a.score);
    highScores.splice(5);

    ///TODO: ECRASER FICHIER JSON
};
