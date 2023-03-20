import "../css/card.css";
import Figure from "./Figure";
import { Dim } from "./TextTags";

export const CardHolder = (props) => (
    <Figure figureName="card">
        {props?.children}
        <div className="image-holder"><img src="" alt="car"/></div>
        <div className="card-content">
            <div>
                <h1>SONATA</h1>
                <p>1050р/мес</p>
            </div>
            <Dim>Some description of car in few words. features.</Dim>
        </div>
        <button>Аренда</button>
    </Figure>
) 