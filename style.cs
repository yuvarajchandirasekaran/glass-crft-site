@font-face {
  font-family: 'Open Sans';
  font-style: normal;
  font-weight: 600;
  font-stretch: normal;
  font-display: swap;
  src: url(https://fonts.gstatic.com/s/opensans/v36/memSYaGs126MiZpBA-UvWbX2vVnXBbObj2OVZyOOSr4dVJWUgsgH1y4n.ttf) format('truetype');
}
@font-face {
  font-family: 'Raleway';
  font-style: normal;
  font-weight: 400;
  font-display: swap;
  src: url(https://fonts.gstatic.com/s/raleway/v29/1Ptxg8zYS_SKggPN4iEgvnHyvveLxVvaooCP.ttf) format('truetype');
}
@font-face {
  font-family: 'Raleway';
  font-style: normal;
  font-weight: 500;
  font-display: swap;
  src: url(https://fonts.gstatic.com/s/raleway/v29/1Ptxg8zYS_SKggPN4iEgvnHyvveLxVvoooCP.ttf) format('truetype');
}
@font-face {
  font-family: 'Raleway';
  font-style: normal;
  font-weight: 600;
  font-display: swap;
  src: url(https://fonts.gstatic.com/s/raleway/v29/1Ptxg8zYS_SKggPN4iEgvnHyvveLxVsEpYCP.ttf) format('truetype');
}
@font-face {
  font-family: 'Raleway';
  font-style: normal;
  font-weight: 700;
  font-display: swap;
  src: url(https://fonts.gstatic.com/s/raleway/v29/1Ptxg8zYS_SKggPN4iEgvnHyvveLxVs9pYCP.ttf) format('truetype');
}
@font-face {
  font-family: 'Raleway';
  font-style: normal;
  font-weight: 900;
  font-display: swap;
  src: url(https://fonts.gstatic.com/s/raleway/v29/1Ptxg8zYS_SKggPN4iEgvnHyvveLxVtzpYCP.ttf) format('truetype');
}
@font-face {
  font-family: 'Unna';
  font-style: normal;
  font-weight: 400;
  font-display: swap;
  src: url(https://fonts.gstatic.com/s/unna/v23/AYCEpXzofN0NCpg.ttf) format('truetype');
}
@font-face {
  font-family: 'Unna';
  font-style: normal;
  font-weight: 700;
  font-display: swap;
  src: url(https://fonts.gstatic.com/s/unna/v23/AYCLpXzofN0NMiQusGk.ttf) format('truetype');
}
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-family: var(--raleway);
}
.body {
  background-color: #FFFFFF;
  overflow: hidden;
}
:root {
  --raleway: Raleway, sans-serif;
  --open-sans: Open Sans, sans-serif;
  --unna: Unna, sans-serif;
  --font-prime-color: #333333;
  --font-secondary: #58585A;
  --link-collor: #FFFFFF;
  --third-color: #E84B37;
}
.flex {
  display: flex;
  justify-content: space-between;
  align-items: center;
}
.container {
  max-width: 1366px;
  width: 100%;
  margin: 0 auto;
}
img {
  max-width: 100%;
  width: 100%;
  height: auto;
  display: inline-block;
  vertical-align: middle;
}
li {
  list-style: none;
}
a {
  text-decoration: none;
  color: var(--link-collor);
}
.background-props {
  background-position: center;
  background-size: cover;
  background-repeat: no-repeat;
}
.material-symbols-outlined {
  vertical-align: middle;
  color: var(--font-prime-color);
}
input:focus {
  outline: none;
}
.container {
  max-width: 1236px;
  width: 100%;
  margin: 0 auto;
}
@media screen and (max-width: 1279px) {
  .container {
    max-width: 974px;
  }
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .header {
    height: 70px;
  }
}
@media screen and (max-width: 767px) {
  .glass-craft-homepage .header {
    height: 56px;
  }
}
.glass-craft-homepage .header .container .header-top {
  padding: 10px 0;
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .header .container .header-top {
    display: none;
  }
}
.glass-craft-homepage .header .container .header-top .left .office-avbt {
  font: normal 13px/18px var(--raleway);
  color: var(--third-color);
}
.glass-craft-homepage .header .container .header-top .left .clock-icon {
  color: var(--third-color);
}
.glass-craft-homepage .header .container .header-top .right .material-symbols-outlined {
  margin-right: 5px;
}
.glass-craft-homepage .header .container .header-top .right .ph-no,
.glass-craft-homepage .header .container .header-top .right .location {
  font: normal 13p/15px var(--raleway);
  color: var(--font-prime-color);
}
.glass-craft-homepage .header .container .header-top .right hr {
  border: 1px solid var(--font-prime-color);
  height: 16px;
  margin: 0 14px;
}
.glass-craft-homepage .header .header-bottom {
  background-color: #003B71;
}
.glass-craft-homepage .header .header-bottom .top .inner-container {
  max-width: 1163px;
  padding: 15px 0;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .header .header-bottom .top .inner-container {
    max-width: 974px;
  }
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .header .header-bottom .top .inner-container {
    padding: 15px 25px;
  }
}
@media screen and (max-width: 767px) {
  .glass-craft-homepage .header .header-bottom .top .inner-container {
    padding: 15px 20px;
  }
}
.glass-craft-homepage .header .header-bottom .top .inner-container .hamburg-icon {
  display: none;
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .header .header-bottom .top .inner-container .hamburg-icon {
    display: block;
  }
}
.glass-craft-homepage .header .header-bottom .top .inner-container .hamburg-icon span {
  font-size: 30px;
  color: var(--link-collor);
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .header .header-bottom .top .inner-container .main-logo {
    width: 175px;
    height: 40px;
  }
}
@media screen and (max-width: 767px) {
  .glass-craft-homepage .header .header-bottom .top .inner-container .main-logo {
    width: 135px;
    height: 30px;
  }
}
.glass-craft-homepage .header .header-bottom .top .inner-container .search-cont {
  position: relative;
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .header .header-bottom .top .inner-container .search-cont {
    display: none;
  }
}
.glass-craft-homepage .header .header-bottom .top .inner-container .search-cont input {
  width: 398px;
  height: 42px;
  font: normal 14px/18px var(--raleway);
  color: var(--font-secondary);
  background-color: #E0E0E0;
  border: none;
  padding: 13px 16px;
  padding-right: 45px;
}
.glass-craft-homepage .header .header-bottom .top .inner-container .search-cont input::placeholder {
  font: normal 14px/18px var(--raleway);
  color: var(--font-secondary);
}
.glass-craft-homepage .header .header-bottom .top .inner-container .search-cont .search-icon {
  position: absolute;
  top: 6px;
  right: 10px;
}
.glass-craft-homepage .header .header-bottom .top .inner-container .search-cont .search-icon hr {
  height: 30px;
  border: 1px solid var(--font-prime-color);
  margin-right: 10px;
}
.glass-craft-homepage .header .header-bottom .top .inner-container .search-cont .search-icon div {
  height: 20px;
  width: 20px;
}
.glass-craft-homepage .header .header-bottom .top .inner-container .search-cont .search-icon div img {
  width: 100%;
  height: 100%;
}
.glass-craft-homepage .header .header-bottom .top .inner-container .dealer-login .txt,
.glass-craft-homepage .header .header-bottom .top .inner-container .account-cart .txt {
  font: bold 14px/18px var(--raleway);
  color: var(--link-collor);
}
.glass-craft-homepage .header .header-bottom .top .inner-container .dealer-login .material-symbols-outlined,
.glass-craft-homepage .header .header-bottom .top .inner-container .account-cart .material-symbols-outlined {
  color: var(--link-collor);
}
.glass-craft-homepage .header .header-bottom .top .inner-container .dealer-login .account,
.glass-craft-homepage .header .header-bottom .top .inner-container .account-cart .account {
  margin-right: 30px;
}
@media screen and (max-width: 767px) {
  .glass-craft-homepage .header .header-bottom .top .inner-container .dealer-login .account,
  .glass-craft-homepage .header .header-bottom .top .inner-container .account-cart .account {
    margin-right: 20px;
  }
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .header .header-bottom .top .inner-container .dealer-login {
    display: none;
  }
}
.glass-craft-homepage .header .header-bottom .top .inner-container .account-cart {
  display: none;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .header .header-bottom .top .inner-container .account-cart {
    display: block;
  }
}
@media screen and (max-width: 767px) {
  .glass-craft-homepage .header .header-bottom .top .inner-container .account-cart .account .txt,
  .glass-craft-homepage .header .header-bottom .top .inner-container .account-cart .cart .txt {
    display: none;
  }
}
.glass-craft-homepage .header .header-bottom .wrapp-line {
  border: 1px solid var(--link-collor);
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .header .header-bottom .bottom {
    display: none;
  }
}
.glass-craft-homepage .header .header-bottom .bottom .container {
  max-width: 1000px;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .header .header-bottom .bottom .container {
    max-width: 974px;
  }
}
.glass-craft-homepage .header .header-bottom .bottom .container ul {
  align-items: unset;
}
.glass-craft-homepage .header .header-bottom .bottom .container ul .link.active {
  background-color: #00203D;
}
.glass-craft-homepage .header .header-bottom .bottom .container ul .link {
  padding: 11px 20px;
  font: bold 18px/16px var(--raleway);
  color: var(--link-collor);
}
.glass-craft-homepage .header .header-bottom .bottom .container ul .link a {
  vertical-align: middle;
}
.glass-craft-homepage .header .header-bottom .bottom .container ul .link a .drop-down-icon {
  color: #E84B37;
}
.glass-craft-homepage .body-container .button-props {
  display: inline-block;
  font: bold 16px/20px var(--raleway);
  color: #6E605D;
  padding: 15px 60px;
  background-color: var(--link-collor);
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .button-props {
    font-size: 12px;
    line-height: 15px;
    padding: 11px 45px;
  }
}
.glass-craft-homepage .body-container .carousal {
  background-image: url(images/curosal-bg.png);
  background-position: center;
  background-size: cover;
  background-repeat: no-repeat;
  padding: 54px 35px;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .body-container .carousal {
    padding: 12px 25px;
  }
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .carousal {
    padding: 7px 20px;
  }
}
@media screen and (max-width: 767px) {
  .glass-craft-homepage .body-container .carousal {
    background-image: unset;
    padding: 0;
  }
}
.glass-craft-homepage .body-container .carousal .mobile-image {
  display: none;
}
@media screen and (max-width: 767px) {
  .glass-craft-homepage .body-container .carousal .mobile-image {
    display: block;
  }
}
.glass-craft-homepage .body-container .carousal .card {
  padding: 30px 20px;
  background-color: #6e605ded;
  max-width: 430px;
  width: 100%;
}
@media screen and (max-width: 767px) {
  .glass-craft-homepage .body-container .carousal .card {
    max-width: 100%;
    text-align: center;
    padding: 20px;
  }
}
.glass-craft-homepage .body-container .carousal .card .card-heading {
  font: normal 48px/48px var(--unna);
  color: var(--link-collor);
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .carousal .card .card-heading {
    font-size: 34px;
    line-height: 34px;
  }
}
@media screen and (max-width: 767px) {
  .glass-craft-homepage .body-container .carousal .card .card-heading {
    max-width: 311px;
    margin: 0 auto;
  }
}
.glass-craft-homepage .body-container .carousal .card p {
  font: 500 22px/26px var(--raleway);
  color: var(--link-collor);
  margin: 10px 0 30px;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .body-container .carousal .card p {
    margin: 10px 0 20px;
  }
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .carousal .card p {
    font-size: 18px;
    line-height: 21px;
  }
}
.glass-craft-homepage .body-container .carousal .card a {
  display: inline-block;
  font: bold 16px/20px var(--raleway);
  color: #6E605D;
  padding: 15px 60px;
  background-color: var(--link-collor);
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .carousal .card a {
    font-size: 12px;
    line-height: 15px;
    padding: 11px 45px;
  }
}
.glass-craft-homepage .body-container .our-products {
  margin-top: 50px;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .body-container .our-products {
    margin-top: 46px;
  }
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .our-products {
    margin-top: 30px;
  }
}
.glass-craft-homepage .body-container .our-products .heading {
  text-align: center;
  max-width: 720px;
  width: 100%;
  margin: 0 auto;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .body-container .our-products .heading {
    max-width: 630px;
  }
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .our-products .heading {
    max-width: 590px;
  }
}
.glass-craft-homepage .body-container .our-products .heading h2 {
  font: normal 42px/48px var(--unna);
  color: var(--font-prime-color);
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .our-products .heading h2 {
    font-size: 36px;
    line-height: 40px;
  }
}
.glass-craft-homepage .body-container .our-products .heading p {
  font: 500 18px/22px var(--raleway);
  color: var(--font-prime-color);
  margin: 14px 0 40px;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .body-container .our-products .heading p {
    margin: 14px 0 32px;
    font-size: 16px;
    line-height: 20px;
  }
}
@media screen and (max-width: 600px) {
  .glass-craft-homepage .body-container .our-products .heading p {
    max-width: 335px;
    width: 100%;
    margin: 14px auto 30px;
  }
}
.glass-craft-homepage .body-container .our-products .sample-visuals {
  padding: 0 45px;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals {
    padding: 0 25px;
  }
}
@media screen and (max-width: 767px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals {
    flex-flow: column;
    padding: 0 38px;
  }
}
.glass-craft-homepage .body-container .our-products .sample-visuals .product {
  max-width: 410px;
  width: 100%;
  margin: 0 auto;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals .product {
    max-width: 307px;
  }
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals .product {
    max-width: 228px;
  }
}
@media screen and (max-width: 767px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals .product {
    max-width: 100%;
    margin-bottom: 50px;
  }
}
.glass-craft-homepage .body-container .our-products .sample-visuals .product .prod-image {
  max-width: 410px;
  width: 100%;
  margin: 0 auto;
}
@media screen and (max-width: 400px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals .product .prod-image {
    max-width: 228px;
  }
}
@media screen and (max-width: 767px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals .product .about {
    max-width: 300px;
    margin: 0 auto;
  }
}
.glass-craft-homepage .body-container .our-products .sample-visuals .product .about .prod-name {
  font: 400 31px/36px var(--unna);
  color: var(--font-prime-color);
  margin-top: 20px;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals .product .about .prod-name {
    margin-top: 16px;
    font-size: 24px;
  }
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals .product .about .prod-name {
    margin-top: 13px;
    line-height: 24px;
  }
}
.glass-craft-homepage .body-container .our-products .sample-visuals .product .about p {
  font: 500 16px/20px var(--raleway);
  color: var(--font-prime-color);
  margin: 12px 0 20px;
  height: 65px;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals .product .about p {
    height: 70px;
    font-size: 14px;
    line-height: 18px;
  }
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals .product .about p {
    font-size: 13px;
    line-height: 16px;
  }
}
.glass-craft-homepage .body-container .our-products .sample-visuals .product .about a {
  display: inline-block;
  font: bold 16px/20px var(--raleway);
  color: #6E605D;
  padding: 15px 60px;
  background-color: var(--link-collor);
  background-color: var(--font-prime-color);
  color: var(--link-collor);
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals .product .about a {
    font-size: 12px;
    line-height: 15px;
    padding: 11px 45px;
  }
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals .product .about a {
    font-size: 14px;
  }
}
.glass-craft-homepage .body-container .our-products .sample-visuals .itm-2 {
  margin: 0 35px;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals .itm-2 {
    margin: 0 25px;
  }
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals .itm-2 {
    margin: 0 20px;
  }
}
@media screen and (max-width: 767px) {
  .glass-craft-homepage .body-container .our-products .sample-visuals .itm-2 {
    margin: 0;
    margin-bottom: 50px;
  }
}
.glass-craft-homepage .body-container .product-catelog-sec {
  padding-left: 124px;
  margin-top: 100px;
  margin-bottom: 100px;
}
.glass-craft-homepage .body-container .product-catelog-sec .wrapper .txt-cont {
  max-width: 410px;
  width: 100%;
  margin-right: 30px;
}
.glass-craft-homepage .body-container .product-catelog-sec .wrapper .txt-cont .prod-name {
  font: 400 31px/36px var(--unna);
  color: var(--font-prime-color);
  margin-top: 20px;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .body-container .product-catelog-sec .wrapper .txt-cont .prod-name {
    margin-top: 16px;
    font-size: 24px;
  }
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .product-catelog-sec .wrapper .txt-cont .prod-name {
    margin-top: 13px;
    line-height: 24px;
  }
}
.glass-craft-homepage .body-container .product-catelog-sec .wrapper .txt-cont p {
  font: 500 16px/20px var(--raleway);
  color: var(--font-prime-color);
  margin: 12px 0 20px;
  height: 65px;
}
@media screen and (max-width: 1279px) {
  .glass-craft-homepage .body-container .product-catelog-sec .wrapper .txt-cont p {
    height: 70px;
    font-size: 14px;
    line-height: 18px;
  }
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .product-catelog-sec .wrapper .txt-cont p {
    font-size: 13px;
    line-height: 16px;
  }
}
.glass-craft-homepage .body-container .product-catelog-sec .wrapper .txt-cont a {
  display: inline-block;
  font: bold 16px/20px var(--raleway);
  color: #6E605D;
  padding: 15px 60px;
  background-color: var(--link-collor);
  background-color: #6E605D;
  color: var(--link-collor);
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .product-catelog-sec .wrapper .txt-cont a {
    font-size: 12px;
    line-height: 15px;
    padding: 11px 45px;
  }
}
@media screen and (max-width: 1023px) {
  .glass-craft-homepage .body-container .product-catelog-sec .wrapper .txt-cont a {
    font-size: 14px;
  }
}
.glass-craft-homepage .body-container .product-catelog-sec .wrapper .sample-images {
  max-width: 964px;
  width: 100%;
  margin-right: -197px;
}
