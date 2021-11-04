import React from 'react';

class CustomerList extends React.Component{
    
    constructor(props){
        super(props);
        console.log("In CustomerList.constructor");
        this.state = { customers: [] }; //This.state allows users to modify data on a page in real time.
    }

    componentDidMount(){
        console.log("In LifeCycleReact.render");
        fetch('https://localhost:44391/api/customers')
            .then(response => response.json())
            .then(json => {
                console.log(json);
                this.setState({customers: json});
                console.log("Component state has been modified.");
            });
        console.log("One made the fetch call.");     
    } 

    render(){
        console.log("In CustomerList.render");

        let list = [];
        for (let index = 0; index < this.state.customers.length; index++) {
            const customer = this.state.customers[index];
            list.push(<p>Id: {customer.customerId} – Name: {customer.companyName}</p>);
        }
        return (
            <div>
                <h1>Customer List</h1>
                <p>Number of customer: {this.state.customers.length}</p>
                {list}
            </div>);
    }    
}
export default CustomerList;