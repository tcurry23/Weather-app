import React, { Component } from 'react';
import Title  from './components/title';
import Form from './components/form'
import Weather from './components/weather'


const API_KEY = 'f7998e9595a79b21dc7de5e53afba2d7';
class App extends Component {
  getWeather = async (e) => {
    e.preventDefault();
    const api_call = await fetch(`https://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=${API_KEY}`);
    const  data = await api_call.json();
    console.log(data);
    
  }
  state = {  }
  render() { 
    return ( 
      <div>
        <Title />
        <Form getWeather={this.getWeather}/>
        <Weather />
      </div>
     );
  }
}
 
export default App;