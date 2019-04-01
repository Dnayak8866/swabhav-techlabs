import { Component, ViewChild } from "@angular/core";
import { Slides } from "ionic-angular";

@Component({
    selector:'page-slidepreview',
    templateUrl:'slidePreview.html'
})
export class SlidePreview{

    constructor(){
        
    }

    @ViewChild(Slides) slides: Slides;

    ngOnInit(): void {
      this.slides.ionSlideProgress.subscribe(progress => this.onProgress(progress));
    }
  
    onProgress(centerX: number): void {
      let maxScale = 3;
      let slideCount = this.slides._slides.length;
      let slideDelta = 1 / (slideCount - 1)
      let slope = (maxScale - 1) / slideDelta;
      for (let slideIndex = 0; slideIndex < slideCount; slideIndex++) {
        let slideX = slideIndex * slideDelta;
        let slideScale = 1;
        if (slideX > centerX - slideDelta) {
          if (slideX <= centerX) {
            slideScale += (slideX - (centerX - slideDelta)) * slope;
          } else if (slideX < centerX + slideDelta) {
            slideScale += ((centerX + slideDelta) - slideX) * slope;
          }
        }
        this.slides._slides[slideIndex].style.transform = `scale(${slideScale})`;
      }
    }
}