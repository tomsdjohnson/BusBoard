import React, { Component } from 'react';

export class Home extends Component {


    render() {

        var displayName = Home.name;

        return (
            <div>
                <h1>Tube Journey Planner</h1>

                <form>
                    From:<br></br>
                    <input type="text" name="firstname"></input><br></br>
                    To:<br></br>
                    <input type="text" name="lastname"></input><br></br>
                    <button type="button">Go</button>
                </form>

            </div>
            );
    }
}