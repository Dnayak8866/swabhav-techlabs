import { PipeTransform, Pipe } from "@angular/core";


@Pipe({name:'gendertocolor'})
export class GenderToColorPipe implements PipeTransform{
    transform(value:string):string{
        if(value=="male"){
            return "Grey";
        }
        return "pink";
    };

}