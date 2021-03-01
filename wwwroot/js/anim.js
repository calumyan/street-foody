﻿// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var active = true;

function animateLines(e) {
  var line1 = document.getElementById("line1");
  var line3 = document.getElementById("line3");
  var deg;
  var id;

  if (active) {
    deg = 0;
    id = setInterval(activateAnim, 3);
  } else {
    deg = 45;
    id = setInterval(deactivateAnim, 3);
  }

  active = !active;

  function activateAnim() {
    if (deg == 45) {
      clearInterval(id);
    } else {
      deg++;
      line1.style.transform = `rotate(${deg}deg) translateY(0.4em)`;
      line3.style.transform = `rotate(${-deg}deg) translateY(-0.4em)`;
    }
  }
  function deactivateAnim() {
    if (deg == 0) {
      clearInterval(id);
    } else {
      deg--;
      line1.style.transform = `rotate(${-deg}deg)`;
      line3.style.transform = `rotate(${deg}deg)`;
    }
  }
  $("#nav-links").toggleClass("open");
  $("#nav-links li").each(function () {
    $(this).toggleClass("fade");
  });
  $("main").toggle();
}

function toggleFilterDesktop() {
  $("#filter-col").toggle();
}

$("#burger").click(animateLines);
$("button#filter").click(toggleFilterDesktop);

//-------------- SEARCH PAGE ----------------

const vendorCards = document.querySelectorAll(".vndr-card");
const carets = document.querySelectorAll(".right-caret > img");
const resultCol = document.querySelector("#result-col");

function moveCaret(e) {
  let mouse = e.target;
  for (let i = 0; i < vendorCards.length; i++) {
    if (mouse === vendorCards[i]) {
      carets[i].classList.add("active");
    } else {
      carets[i].classList.remove("active");
    }
  }
}

resultCol.addEventListener("mousemove", moveCaret);
