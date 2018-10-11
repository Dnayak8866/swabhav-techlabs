import {Promise} from "q";
export class MathServices{


    isPrime(num:number):boolean{
        for(let i=2;i<=num/2;i++){
            if(num%i==0){
                return false;
            }
        }
        return true;
    }

    isPrimeAsync(num:number){
        let result;

        let res=  Promise((resolve,reject)=>{
            for(let i=2;i<=num/2;i++){
                if(num%i==0){
                     result="Not a prime...";
                     reject(result);
                }
            }
            result="Prime number.....";
            resolve(result);
        });
        
        return res;
        
    }
}