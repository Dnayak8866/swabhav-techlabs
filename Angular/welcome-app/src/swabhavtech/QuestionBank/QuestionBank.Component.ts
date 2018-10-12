import { Component, ViewChild, ElementRef } from "@angular/core";

@Component({ templateUrl: 'QuestionBank.Component.html', selector: "st-questionbank" })
export class QuestionBankComponent {
  Questions: any[];
  index: number;
  questionObj: any;
  optionIndex: number;
  radioVal: any;
  selectedAnswers: string[];
  noQuestions: number;
  disableNextBtn = false;
  hideShowResultBtn = true;
  hideQuestionSection = false;
  noCorrectAnswers: number;
  congoText: string;
  hideSelectedAnsText= false;;
  hideCongoDiv=true;
  percent:number;
  hideCanvas=true;

  @ViewChild('mycanvas') mycanvas:ElementRef;



  constructor() {
    this.Questions = [
      {
        id: 1,
        title: "World’s first artificial satellite was?",
        answer: "Sputnik I",
        options: ["Satnek", "Sputnik I", "Rubnik", "Satneo"]
      },
      {
        id: 2,
        title: "How big is the SAHARA DESERT in African continent?",
        answer: "9,200,000sqkm",
        options: ["9,200,000sqkm", "9,800,000sqkm", "8,200,000sqkm", "9,700,000sqkm"]
      },
      {
        id: 3,
        title: "When the World Environment Day observed worldwide every year?",
        answer: "5june",
        options: ["5jan", "5june", "4june", "5july"]
      },
      {
        id: 4,
        title: "The Biggest island in the world?",
        answer: "Greenland",
        options: ["Greenland", "Scotland", "Whiteisland", "Newland"]
      },
      {
        id: 5,
        title: "In which indian state is the sun temple of konark located?",
        answer: "Odisha",
        options: ["Gujarat", "Delhi", "Odisha", "Bihar"]
      }
    ];

    this.selectedAnswers = [];
    this.noCorrectAnswers = 0;
    this.index = 0;
    this.showQuestion(this.index);
    this.noQuestions = this.Questions.length;
    
  }

  showQuestion(position: number) {

    if (position != 0) {
      this.storeAnswer(this.radioVal);
    }
    if (position >= this.noQuestions) {
      this.disableNextBtn = true;

      console.log("inside...");
      this.hideShowResultBtn = false;
      this.hideQuestionSection = true;
      this.hideSelectedAnsText=true;
    
      return;
    }
    this.questionObj = this.Questions[position];


 

    this.index++;

  }
  storeAnswer(answer: string) {
    this.selectedAnswers.push(answer);
    console.log(this.selectedAnswers);
  }

  checkResult() {
   
    for (let i = 0; i < this.noQuestions; i++) {
      if (this.selectedAnswers[i] == this.Questions[i].answer) {
        
        this.noCorrectAnswers++;

      }
    }
    this.hideCongoDiv=false;
    this.percent=this.calculatePercentage(this.noCorrectAnswers);
    this.showCanvas(this.mycanvas);
    
    if(this.percent>50){
      return this.congoText="Congratulations you have passed Quiz.....";
    }
    this.congoText="Oops you failed......"
    
    console.log("Correct answers :" + this.noCorrectAnswers);
  }

  calculatePercentage(points: number):number {
    let percentage = (points / this.noQuestions) * 100;
    console.log("Percentage:" + percentage);
    return percentage
  }

  showCanvas(mycanvas:ElementRef){
    this.hideCanvas=false;
    //getting canvas element
    let ctx=mycanvas.nativeElement.getContext("2d");

    this.createArc(ctx, 0, this.percent * 0.01, "green");
    this.createArc(ctx, this.percent * 0.01, 1, "red");
   

  };

  createArc(ctx:CanvasRenderingContext2D,x,y,color){
    ctx.beginPath();
    ctx.moveTo(250, 250);
    ctx.arc(250, 250, 150, 2 * Math.PI * x, 2 * Math.PI * y);
    ctx.fillStyle = color;
    ctx.fill();
  }









}
