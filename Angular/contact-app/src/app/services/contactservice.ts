import { Icontact } from "./Icontact";
import { resolve } from "dns";
import { reject } from "q";

export class ContactService{

    contacts:Icontact[];
    contactIndex:number;

    constructor(){
        this.contacts=[{name:"dharmesh",num:9889},{name:"chandan",num:846000}];
    }

    // addContact(name:string,num:number){
    //     this.contacts.push({name:name,num:num});
    //     console.log("Contact added...");
    // }

    addContact(name:string,num:number){
        return new Promise((resolve,reject)=>{
            if(name!=null && num!=null){
                this.contacts.push({name:name,num:num});
                resolve(true);
            }
            reject(false);
        });
    }

    getAllContacts():Icontact[]{
        return this.contacts
    }

    getContactIndex(name:string):void{
        for(let i=0;i<this.contacts.length;i++){
            if(this.contacts[i].name==name){
                this.contactIndex=i;
                break;
            }
        }
    }
    // updateContact(name:string,num:number){
    //     if(name==null && num==null){
    //         return;
    //     }else if(name==null){
    //         return this.contacts[this.contactIndex].num=num;
    //     }
    //     this.contacts[this.contactIndex].name=name;
    
    // }

    updateContact(name:string,num:number){
        return new Promise((resolve,reject)=>{
            if(name==null && num==null){
                reject(false);
                return;
            }else if(name==null){
                this.contacts[this.contactIndex].num=num;
                resolve(true);
                return;
            }
            this.contacts[this.contactIndex].name=name;
            resolve(true);
        });
    }


    // deleteContact(){
    //     this.contacts.splice(this.contactIndex,1);
    // }

    deleteContact(){
        return new Promise((resolve,reject)=>{
            if(this.contacts.splice(this.contactIndex,1)){
                resolve(true);
            }
            reject(false);
        });
    }
    

}