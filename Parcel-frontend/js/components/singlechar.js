import apiActions from "../api/api-actions";

export default function SingleChar(char){
    return `
    <div>
        <p>${char.name}</p>
        <p>${char.health}</p>
        <p>${char.description})}</p>
    `
}