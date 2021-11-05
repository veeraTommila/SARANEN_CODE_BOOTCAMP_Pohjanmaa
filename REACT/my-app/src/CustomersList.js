import React from 'react';

class CustomerList extends React.Component {

    constructor(props) {
        super(props);
        console.log("In CustomerList.constructor");
        this.state = {
            customers: []
        };
    }; //This.state allows users to modify data on a page in real time.
}

componentDidMount() {
    console.log("In CustomerList.componentDidMount");

    fetch('https://localhost:44378/api/customers')
        .then(response => response.json())
        .then(json => {
            console.log(json);
            this.setState({
                customers: json
            });
            console.log("Component state has been modified.");
        });
    console.log("Fetch call has been made.");
}
myButtonClickHandler() {
    console.log("Button was clicked!");
    // alert("Hello from React!");

    const data = {
        username: 'Tom Tester',
        shoenumber: 42
    };
    fetch('https://localhost:44378/api/hello', {
            method: 'POST', //Send data request back.
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(data),
        })
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data.text);
            alert(data.text);
        });
}

render() {
    //console.log("In CustomerList.render");

    //let list = []; //pushing data to an array.
    /*for (let index = 0; index < this.state.customers.length; index++) {
        const customer = this.state.customers[index];
        list.push(<p>Id: {customer.customerId} – Name: {customer.companyName}</p>);
    }*/
    console.log("In CustomerList.render");

        let list = [];
        for (let index = 0; index < this.state.customers.length; index++) {
            const customer = this.state.customers[index];
            list.push(<tr>
                <td>{customer.customerId}</td>
                <td>{customer.companyName}</td>
                <td>{customer.contactName}</td>
                <td>{customer.city}</td>
            </tr>);
    }    

    return ( <div>
        <h1>Customer List</h1>
        <button onClick={this.myButtonClickHandler} className="btn btn-outline-primary mt-2 mb-2">Click me!</button>
        <p>Number of customer: {this.state.customers.length}</p>
        <table className="table table-striped w-75">
            <thead>
                <tr>
                    <th>Customer Id</th>
                    <th>Company Name</th>
                    <th>Contact Name</th>
                    <th>City</th>
                </tr>
            </thead>
            <tbody>
                {list}
            </tbody>
        </table>
    </div>);
    
}
export default CustomerList;