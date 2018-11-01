import {Http} from "@angular/http"
import { ILoginDetailDTO } from "../DTOs/Ilogindetail_DTO";
import { Injectable } from "@angular/core";
import { ILoginDTO } from "../DTOs/ILoginDTO";

@Injectable()
export class LoginService{
    constructor(private _http:Http){

    }

    logindetail:ILoginDTO;
    authenticateUser(username:string,password:string){
        this.logindetail={
            username:username,
            password:password,
            
        }
        return this._http.post("http://192.168.2.11/TenantApi/api/tenant/LoginDetails/CheckUser",this.logindetail).toPromise();
    }
}