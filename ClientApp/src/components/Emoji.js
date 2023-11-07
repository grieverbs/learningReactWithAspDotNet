import React, { Component } from 'react';

export class Emoji extends Component {
    static displayName = Emoji.name;

    constructor(props) {
        super(props);
        this.state = {
            emojis: [],
            loading: true,
            text: "test"
        }
    }

    componentDidMount() {
        this.getData();
    }

    render() {
        let content = this.state.loading ? <div>I'm loading data!</div> : Emoji.renderData(this.state.emojis);
        return (
            <div>{content}</div>
        )
    }

    async getData() {
        const response = await fetch('api/emoji');
        const data = await response.json();
        this.setState({ emojis: data, loading: false });
    }

    static renderData(emojis) {
        return (
            <table className="table table-striped" aria-labelledby="tableLabel">
                <thead>
                    <tr>
                        <th>Name</th>
                        <th>Image URL</th>                        
                    </tr>
                </thead>
                <tbody>
                    {emojis.map(emoji =>
                        <tr key={emoji.name}>
                            <td>{emoji.name}</td>
                            <td>{emoji.imageUrl}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        )
        /*
         * Can't do this
         * return { emojis }
         * Objects are not valid as a React child (found: object with keys {emojis}). If you meant to render a collection of children, use an array instead.
         */

    }
};