import { Component, OnInit, Input, Output, EventEmitter } from "@angular/core";

@Component({ templateUrl: "togglebutton.component.html", selector: "st-togglebutton" })
export class ToggleButtonComponent implements OnInit {

    @Input()
    textinput: string;
    @Input()
    onStateColor: string;
    @Input()
    offStateColor: string;

    @Output()
    statechange:EventEmitter<string> = new EventEmitter();

    stateColor: string;
    isOn = false;
    constructor() {
        console.log("Inside constructor..");
        //  console.log(this.textinput);
        //this.textinput="nothing";

    }

    ngOnInit(): void {
        console.log("Inside onInit...");
        //this.textinput="nothing";
        this.stateColor = this.offStateColor;
        console.log(this.textinput);
    }

    toggleStateColor() {
        if (this.isOn) {
           
            this.isOn = false;
            this.stateColor = this.offStateColor;
            this.statechange.emit(`StateChanged from ON to OFF
            Color changed from `+this.onStateColor+` to `+this.stateColor);
            return 

        }
       
        this.isOn = true;
        this.stateColor = this.onStateColor;
        this.statechange.emit(`StateChanged from OFF to ON
        Color changed from `+this.offStateColor+` to `+this.stateColor)
        
       
    }





}