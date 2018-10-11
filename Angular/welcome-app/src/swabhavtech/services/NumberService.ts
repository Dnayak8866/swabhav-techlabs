import{Http} from '@angular/http';
import{Injectable} from '@angular/core'

@Injectable()
export class NumberServices{

   
    constructor(private http:Http){

    }
    getData(num:number){
       return this.http.get("http://numbersapi.com/" + num).toPromise();
    }

}