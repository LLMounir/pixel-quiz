import 'package:flutter/material.dart';
import '../utils/question.dart';
import '../utils/quiz.dart';
import '../UI/answer_button.dart';
import '../UI/question_text.dart';
import '../UI/correct_wrong_overlay.dart';
import '../pages/score_page.dart';
import '../utils/json_to_list.dart';

class QuizPage extends StatefulWidget {
  @override
  State createState() => new QuizPageState();
}

class QuizPageState extends State<QuizPage> {
  Question currentQuestion;
  //Quiz quiz = new Quiz(JsonToList(""));
  Quiz quiz = new Quiz([
    new Question("Q1", false, "wa1", "wa2", "wa3"),
    new Question("Q2", true, "wa1", "wa2", "wa3"),
    new Question("Q3", true, "wa1", "wa2", "wa3"),
    new Question("Q4", false, "wa1", "wa2", "wa3")
  ]);
  String questionText;
  int questionNumber;
  bool isCorrect;
  bool overlayShouldBeVisible = false;

  @override
  void initState() {
    super.initState();
    currentQuestion = quiz.nextQuestion;
    questionText = currentQuestion.question;
    questionNumber = quiz.questionNumber;
  }

  void handleAnswer(bool answer) {
    isCorrect = (currentQuestion.answer == answer);
    quiz.answer(isCorrect);
    this.setState(() {
      overlayShouldBeVisible = true;
    });
  }

  @override
  Widget build(BuildContext context) {
    return new Stack(
      fit: StackFit.expand,
      children: <Widget>[
        new Column(
          // this is our main page
          children: <Widget>[
            new AnswerButton(true, () {
              handleAnswer(true);
            }),
            new QuestionText(questionText, questionNumber),
            new AnswerButton(false, () {
              handleAnswer(false);
            })
          ],
        ),
        overlayShouldBeVisible == true
            ? CorrectWrongOverlay(isCorrect, () {
                if (quiz.length == questionNumber) {
                  Navigator.of(context).pushAndRemoveUntil(
                      new MaterialPageRoute(
                          builder: (BuildContext context) =>
                              new ScorePage(quiz.score, quiz.length)),
                      (Route route) => route == null);
                }
                currentQuestion = quiz.nextQuestion;
                this.setState(() {
                  overlayShouldBeVisible = false;
                  questionText = currentQuestion.question;
                  questionNumber = quiz.questionNumber;
                });
              })
            : new Container()
      ],
    );
  }
}
