export class Student{

    constructor(private _firstname:string,private _lastname:string){

    }

    public get Details():string{
        return `Student details  
                    firstname:${this._firstname}
                    Lastname:${this._lastname}`

    }
}

/* let s1 = new Student("Dharmesh","Nayak");
let s2 = new Student("Chandan","Maharana");

console.log( s1.Details);
console.log(s2.Details);  */