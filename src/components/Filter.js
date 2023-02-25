import React, { useEffect, useState } from 'react';
import { Pagination, Input, Row, Col } from 'antd';

///
/// На вход рост, возраст и вес (от и до), а также их хуки
///

const Filter = (
        hT, hF, wT, wF, aT, aF, setHT, setHF, setWT, setWF, setAT, setAF
    ) => {
    return (
        <div style={{ margin: "auto", paddingTop: "50px", paddingBottom: "50px", paddingLeft: "200px" }}>
            <Input.Group size="large" className='Age' style={{ marginTop:'50px' }}>
                <div>Максимальный возраст (от, до)</div>
                <Row gutter={8}>
                    <Col span={5}>
                        <Input type='number' defaultValue={aF} title="от" onChange={(e) => {setAF(e.target.value)}}/>
                    </Col>
                    <Col span={8} title="до">
                        <Input type='number' defaultValue={aT} onChange={(e) => {setAT(e.target.value)}}/>
                    </Col>
                </Row>
            </Input.Group >

            <Input.Group size="large" className='Height' style={{ marginTop:'50px' }}>
                <div>Максимальный Рост (от, до)</div>
                <Row gutter={8}>
                    <Col span={5}>
                        <Input type='number' defaultValue={hF} title="от" onChange={(e) => setHF(parseInt(e.target.value))}/>
                    </Col>
                    <Col span={8} title="до">
                        <Input type='number' defaultValue={hT} onChange={(e) => {setHT(parseInt(e.target.value))}}/>
                    </Col>
                </Row>
            </Input.Group >

            <Input.Group size="large" className='Weight' style={{ marginTop:'50px' }}>
                <div>Максимальный вес (от, до)</div>
                <Row gutter={8}>
                    <Col span={5}>
                        <Input type='number' defaultValue={wF} title="от" onChange={(e) => setWF(parseInt(e.target.value))}/>
                    </Col>
                    <Col span={8} title="до">
                        <Input type='number' defaultValue={wT} onChange={(e) => setWT(parseInt(e.target.value))}/>
                    </Col>
                </Row>
            </Input.Group >
        </div>
    )
}

export default Filter;