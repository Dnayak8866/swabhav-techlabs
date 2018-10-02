(function () {

    console.log("heyyyyyy");
    var input=$("#userinput");

    //var input = document.getElementById("userinput");
    var btn=$("#btnAdd");
//    var btn = document.getElementById("btnAdd");
    btn.prop("disabled",true);
  //  btn.disabled=true;
  
    btn.on("click", show);
    //checking for enter key press event
    input.on("keyup", function (event) {
        btn.prop("disabled",false);
       // btn.disabled=false;
        event.preventDefault();
        if (event.keyCode == 13) {
            show();
        }
    });
    
    
    function show() {
        var btn=$("#btnAdd");
       // var btn = document.getElementById("btnAdd");
       btn.prop("disabled",true);
       // btn.disabled=true;
       
       var inputText=$("#userinput").val();
      //  var input = document.getElementById("userinput").value;

        var inputTestnode = document.createTextNode(inputText);
        var node  = $("<h3></h3>")
        //var node = document.createElement("h3");
    
        node.append(inputTestnode);

        var divelement= $("<div></div>");
        divelement.append(node);
        //var divelement = document.createElement("div").appendChild(node);

        var btn=$("<button></button>");
        //var btn = document.createElement("button");

        var btnname = document.createTextNode("X");
        btn.addClass( "btn btn-primary");
      //  btn.setAttribute("class", "btn btn-primary");
      btn.click(function(){
        var div = $(this).parentElement;
        div.hide();
       
      });
      /*  btn.onclick = function () {
            var div = this.parentElement;
            div.style.display = "none";
        } */
        btn.append(btnname);
      //  btn.appendChild(btnname);
        divelement.append(btn);
       // divelement.appendChild(btn);
        $("#container").append(divelement);
       // document.getElementById("container").appendChild(divelement);

    }


})();


