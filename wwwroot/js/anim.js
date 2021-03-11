// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

//=============== NAV BAR ==================

var active = true;
const line1 = document.getElementById("line1");
const line3 = document.getElementById("line3");
const navLinks = document.getElementById("nav-links");
const overlay = document.getElementById("overlay");
const burger = document.getElementById("burger");

function animateLines(e) {
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
  navLinks.classList.toggle("open");
  overlay.classList.toggle("open");
}

overlay.addEventListener("click", () => burger.click());
burger.addEventListener("click", animateLines);

//=============== SEARCH PAGE ==================

// Animate carets --------------------
const vendorCards = document.querySelectorAll(".vndr-card");
const carets = document.querySelectorAll(".right-caret");
const resultCol = document.getElementById("result-col");

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

// Animate filter column --------------------
const filterBtn = document.getElementById("filter");
const filterCol = document.getElementById("filter-col");
const wrapper = document.getElementById("wrapper");

function toggleFilterDesktop() {
  filterCol.classList.toggle("close");
  wrapper.classList.toggle("full");
}

filterBtn.addEventListener("click", toggleFilterDesktop);
