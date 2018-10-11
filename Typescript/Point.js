class Point {
    constructor() {
        this._x = 0;
        /*   public set Y(y:number){
               if(y>=0){
                   this._y=y;
               }
           }
       
           public get Y(){
               return this._y;
           } */
    }
    //  private _y=0;
    set X(x) {
        if (x >= 0) {
            this._x = x;
        }
    }
    get X() {
        return this._x;
    }
}
var p1 = new Point();
console.log(p1);
p1.X = 10;
//p1.Y=5;
console.log(p1.X);
//console.log(p1.Y);
