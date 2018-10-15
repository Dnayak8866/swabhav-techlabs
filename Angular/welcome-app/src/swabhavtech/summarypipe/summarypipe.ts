import { PipeTransform, Pipe } from "@angular/core";
import { pipe } from "rxjs";

@Pipe({name:'summaryPipe'})
export class SummaryPipe implements PipeTransform{

    
    transform(value:string,stringLength:number){

        return value.substring(0,stringLength)+"....";
    }

}