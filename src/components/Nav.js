import React from 'react';
import { useNavigate, Route, Routes } from "react-router-dom";

var Nav = () => {

    let navigate = useNavigate();

    return (
        <>
            <div style={{ width:'100%', height:'90px', backgroundColor: '#6161ff', fontWeight:'90px', fontSize:40, color:'white', marginTop:"0px", 
                    fontFamily:'sans-serif', display:'flex', alignItems:'center', justifyContent:'center'}}>
                       <Routes>
                            <Route path='/' element={<h1 style={{ margin:'0px'}}>Собаки</h1>} />
                            <Route path='/dog' element={<h1 style={{ margin:'0px', cursor:'pointer'}} onClick={() => navigate(-1)}>Назад</h1>} />
                        </Routes>
            </div>
        </>
    )

}

export default Nav; 