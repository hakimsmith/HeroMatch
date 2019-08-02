export default function CharacterResult(characters){
    return `
   <div class = "char-results">

    ${characters.map(character =>{

            return `
        <div class= "char-single-result">
        <a href= "${character.characterUrl}" target="_blank">
        <img src=${character.image}>            
        <p>${character.name}</p>
        </a>

        </div>
    
    
    `        

    }).join("")}
   </div>
    `
}