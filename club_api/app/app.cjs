const express =  require("express")
const bodyParser = require("body-parser")
const cors = require("cors")

const app = express()

app.use(bodyParser.json({ limit : "50mb" }))
app.use(cors({
        origin : "*",
        method : ["GET", "POST", "PUT", "DELETE"]
    })
)

module.exports = {
    app : app
}
