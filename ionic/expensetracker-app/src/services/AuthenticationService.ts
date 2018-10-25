
export class AuthenticationService{

    username="dharmesh"
    pass="111";

    
    
    constructor(){
       
        localStorage["username"]=this.username;
        localStorage["passowrd"]=this.pass;
    }

    authenticateUSer(username:string,passowrd:string):boolean{
        if(username == localStorage.getItem("username") && passowrd==localStorage.getItem("passowrd") ){
            localStorage["loginstatus"]=username;
            return true;
        }
        return false;
    }
    



}