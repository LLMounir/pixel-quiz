const highScoresList = document.getElementById("highScoresList");
//const highScores = JSON.parse(localStorage.getItem("highScores")) || [];

let highScores = {};

let showObj = function(){

  //TODO: sort & limit items

  highScoresList.innerHTML = highScores
    .map(score => {
      return `<li class="high-score">${score.name} - ${score.score} Points</li>`;
    })
    .join("");
}

fetch("../assets/highscores.json")
  .then(function(resp){
    return resp.json();
})
  .then(function(data){
    highScores = data;
    showObj();
  });


