import React, { useEffect, useState } from 'react';
import './App.css';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Dogs from './components/Dogs';
import Nav from './components/Nav';
import About from './components/About';
import { Card, Space, headers } from 'antd';

function App() {

  return (
    <>
      <div>
            <Nav />
            <div style={{ marginTop:'50px', display:'flex', flexWrap:'wrap', flexDirection:'column', justifyContent:'center', alignContent:'center' }}>

                  <Routes>
                    <Route path='/' element={<Dogs />} />
                    <Route path='/dog' element={<About />} />
                  </Routes>
                
            </div>
      </div>
    </>
  );
}

export default App;
