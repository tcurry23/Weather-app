@import url('https://fonts.googleapis.com/css?family=Merriweather:100,200,300,300i,400,400i,700');
@import url('https://fonts.googleapis.com/css?family=Roboto+Slab:400,700');
@import url('https://fonts.googleapis.com/css?family=Open+Sans:300,400');

body {
  font-family: "Open Sans", serif;
}

.wrapper {
  background: linear-gradient(to right, #e67e22, #e74c3c);
  height: 100vh;
  display: flex;
  justify-content: center;
  align-items: center;
}

.main {
  height: 90vh;
  background: #fff;
  box-shadow: 0px 13px 40px -13px rgba(0,0,0,0.75);
  width: 80%;
  margin: 0 auto;
}

.title-container {
  height: 90vh;
  background: url("img/bg.jpg") center center no-repeat;
  background-size: cover;
  display: flex;
  align-items: center;
  justify-content: center;
  text-align: center;
  color: #000;
}

.title-container__title {
  font-size: 50px;
  letter-spacing: 2px;
  line-height: 1.3;
  font-family: 'Roboto Slab', serif;
}

.title-container__subtitle {
  font-style: italic;
  font-weight: 100;
  letter-spacing: 1px;
  line-height: 1.5;
  font-family: "Merriweather", serif;
}

.form-container {
  background-color: #2c3e50;
  height: 90vh;
  padding-top: 100px;
  padding-left: 50px;
}

input[type="text"] {
  background-color: transparent;
  border: 0;
  border-bottom: solid 1px #f16051;
  width: 30%;
  padding-bottom: 4px;
  color: #fff !important;
  font-weight: lighter;
  letter-spacing: 2px;
  margin-bottom: 30px;
  margin-right: 20px;
  font-size: 20px;
}

input[type="text"] { 
    outline: none;
}

input:-webkit-autofill {
    -webkit-box-shadow: 0 0 0 30px #2c3e50 inset;
    -webkit-text-fill-color: #fff !important;
}

button {
  border: 0;
  padding: 8px 20px;
  margin: 0 2px;
  border-radius: 2px;
  font-weight: lighter;
  letter-spacing: 1px;
  font-size: 15px;
  cursor: pointer;
  background-color: #f16051;
  color: #fff;
  font-weight: 100;
}

button:active {
  outline: none;
}

.weather__info {
  width: 60%;
  font-size: 20px;
  font-weight: 200;
  letter-spacing: 2px;
}

.weather__key {
  color: #f16051;
  border-bottom: solid 2px rgba(255,255,255,0.06);
  padding: 20px 0 20px 0;
  font-weight: 400;
}

.weather__key:last-child {
  border: 0;
}

.weather__value {
  color: #fff;
  font-weight: 200;
}

.weather__error {
  color: #f16051;
  font-size: 20px;
  letter-spacing: 1px;
  font-weight: 200;
}
