import React, { Component } from 'react';

class Title extends Component {
    state = {  }
    render() { 
        return ( 
            <div>
                <h1 className="title-container__title"> Weather Finder</h1>
                <p className="title-container__subtitle">Find out temperature, conditions, and more...</p>
            </div>
         );
    }
}
 
export default Title;
