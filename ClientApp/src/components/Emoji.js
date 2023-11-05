import React, { Component } from 'react';

export class Emoji extends Component {
    static displayName = Emoji.name;

    constructor(props) {
        super(props);
        this.state = {
            emojis: [],
            loading: true
        }
    }

    componentMount() {
        console.log("componentMount");
        this.getData();
    }

    render() {
        let content = !this.state.loading ? <div>I'm loading data!</div> : Emoji.renderData(this.state.emojis);
        return (
            <div>{content}</div>
        )
    }

    async getData() {
        console.log("getData");
        const response = await fetch('emoji');
        console.log(response)
        //const data = await response.json();
        //console.log(data);
        this.setState({ emojis: [], loading: false });
    }

    static renderData(emojis) {
        return <div>bad</div>
        /*
         * Can't do this
         * return { emojis }
         * Objects are not valid as a React child (found: object with keys {emojis}). If you meant to render a collection of children, use an array instead.
         */
        
    }
};