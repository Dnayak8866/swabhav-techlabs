
import {IUser} from "./IUser";
export class LoginService{

    users:IUser[];
    loggedInUser:string;
    constructor(){
       this.users=[{id:"dharmesh",password:"111"},{id:"chandan",password:"222"}];      
    }

    authenticateUser(inputId:string,inputPass:string):boolean{
      for(let user of this.users){
        if(user.id==inputId && user.password==inputPass){
            this.loggedInUser=inputId;
            return true;
        }
        
      }
      return false;
       
    }

}