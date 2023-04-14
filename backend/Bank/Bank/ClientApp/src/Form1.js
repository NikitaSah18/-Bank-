import React, { Component } from 'react';

import { Form } from 'react-bootstrap';





export class Form1 extends Component {

    static displayName = Form1.name;

    constructor(props){

        super(props);
        this.state = {
            fio :'',
            phone : '',
            adress:''

        }

       
        this.onInputChange = this.onInputChange.bind(this);
        this.sendClientData = this.sendClientData.bind(this);

    }

    onInputChange(event) {
        this.setState({
            [event.target.name]: event.target.value
        });
    }

    render() {

        return (
            <div>
                <div class="form-row">
                    <div class="form-group col-md-6">
                        <label for="inputName">ФИО</label>
                        <input class="form-control" type="text" id="inputfio" placeholder="" value={this.state.fio} name="fio" onChange={this.onInputChange} />
                    </div>
                    <div class="form-group col-md-6">
                        <label for="inputPassword4">Телефон</label>
                        <input class="form-control" id="inputPhone" type="text" value={this.state.phone} name="phone" onChange={this.onInputChange} />
                    </div>
                </div>
                <div class="form-group col-md-6">
                    <label for="inputAddress">Адрес</label>
                    <input class="form-control" id="inputAddress" type="text"  placeholder="Например : ул.Интернациональная д.14 кв.71" value={this.state.adress} name="adress" onChange={this.onInputChange} />
                </div>
                <div>
                    <div class="form-group col-md-4">
                        <label for="inputProduct">Продукт</label>
                        <select id="inputState" class="form-control">
                            <option selected>Выбрать</option>
                            <option>Микрозайм</option>
                            <option>Потребительский кредит</option>
                            <option>Ипотечное кредитование</option>
                        </select>
                    </div>
                </div>
                <button class="f-button" onClick={this.sendClientData}> Продолжить</button>
            </div>
        );

       
    }
    async sendClientData() {
        let client = {
            "FIO": this.state.fio,
            "Phone": this.state.phone,
            "Adress": this.state.adress
        };
        console.log(client);

        const reponse = await fetch('https://localhost:7134/api/admin/client/create', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
                'Authorization': 'Basic dGVzdDp0ZXN0Mg=='
            },
            body: JSON.stringify(client)
        });

        const data = await reponse.json();
        console.log(data);
    }
}