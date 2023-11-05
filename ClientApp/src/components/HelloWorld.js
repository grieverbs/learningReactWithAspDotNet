import React, { Component } from 'react';

export class HelloWorld extends Component {
    static displayName = HelloWorld.name;

    constructor(props) {
        super(props);
        this.state = {
            messages: null,
            loading: true
        }
            ;
    }

    componentDidMount() {
        this.populateData();
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : HelloWorld.renderMessage(this.state.messages);

        return (
            <div>
                <h1 id="tableLabel">My first api call!</h1>
                {contents}
            </div>
        );
    }

    async populateData() {
        const response = await fetch('helloworld');
        const data = await response.json();
        this.setState({ messages: data, loading: false });
    }

    static renderMessage(messages) {
        return (
            <div>
                <div>The following message is coming from api/HelloWorld</div>
                {messages.map(message => 
                    <div key={ message }>
                        <span>{message}</span>
                        <span>, </span>
                    </div>
                )}
            </div>
        );
    }
}
