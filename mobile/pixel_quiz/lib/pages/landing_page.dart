import 'package:flutter/material.dart';
import 'package:animated_text_kit/animated_text_kit.dart';
import 'quiz_page.dart';

class LandingPage extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return new Material(
      color: Colors.blueGrey,
      child: new InkWell(
        onTap: () => Navigator.of(context).push(new MaterialPageRoute(
            builder: (BuildContext context) => new QuizPage())),
        child: new Column(
          mainAxisAlignment: MainAxisAlignment.center,
          children: <Widget>[
            new Text(
              "Pixel Quiz",
              style: new TextStyle(
                  color: Colors.white, fontSize: 99.0, fontFamily: 'Remachine'),
            ),
            new Padding(padding: new EdgeInsets.only(bottom: 15.0)),
            SizedBox(
              width: 250.0,
              child: FadeAnimatedTextKit(
                  onTap: () {
                    print("Tap Event");
                  },
                  text: ["Tap to start!", "Tap to start!", "Tap to start!"],
                  textStyle: TextStyle(
                      fontSize: 28.0,
                      fontWeight: FontWeight.bold,
                      color: Colors.white),
                  textAlign: TextAlign.center,
                  alignment: AlignmentDirectional.topStart),
            )
          ],
        ),
      ),
    );
  }
}
