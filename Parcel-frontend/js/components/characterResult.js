export default function CharacterResult(characters){
    return `
   <div class = "char-results">

    ${characters.map(character =>{

            return `
        <div class= "char-single-result">
            <img src=${character.image}>
            <p>${character.name}</p>

        </div>
    
    
    `        

    }).join("")}
   </div>
    `
}