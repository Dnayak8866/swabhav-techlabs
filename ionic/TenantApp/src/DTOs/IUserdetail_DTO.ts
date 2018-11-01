import { IAddressDTO } from "./IAddress_DTO";
import { IContactDTO } from "./IContact_DTO";

export interface IUserdetailDTO{
    
    Name:string;
    Currency:string;
    ShortName:string;
    UserRole:string;
    WebUrl:string;

    address:IAddressDTO[];
    contact:IContactDTO[];



}