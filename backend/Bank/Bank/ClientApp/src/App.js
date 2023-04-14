import React from 'react';
import './App.css';
import 'bootstrap/dist/css/bootstrap.min.css';

import Footer from "./components/Footer";
import NaviBar from './components/NaviBar';

import { BrowserRouter } from 'react-router-dom';
import { Routes, Route } from 'react-router-dom';




import { Form1 } from './Form1';
import { Home } from './components/Home';
import { Company } from './Company';
import { Credits } from './Credits';

function App() {
    return (
        <>


           
                <NaviBar />
                <Routes>

                    <Route path="/" element={<Home />} />
                    <Route path="/Company" element={<Company />} />
                    <Route path="/Credits" element={<Credits />} />
                    <Route path="/Form" element={<Form1 />} />
                </Routes>
            

            <Footer />
        </>

    );
}

export default App;