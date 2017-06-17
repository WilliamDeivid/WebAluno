  function openNav(){
      document.getElementById("SlideMenuNav").style.display="block"
  }
function closeNav(){
    document.getElementById("SlideMenuNav").style.display="none"
}
function showresponddiv(e){
    var n=e.replace("submenu-","opensubmenu-"),l=document.getElementById(n);current&&current!=l&&(current.style.display="none"),"none"==l.style.display?(l.style.display="block",current=l):l.style.display="none"
}
var current=null;


function fixOpacity(){
    document.getElementById("menuOpacity").style.opacity = "0.6";
    document.getElementById("menuOpacity").style.transition = "0.4s";
}
function fixOpacity2(){
    document.getElementById("menuOpacity").style.opacity = "1";
    document.getElementById("menuOpacity").style.transition = "0.4s";
}
