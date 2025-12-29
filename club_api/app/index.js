import { app } from "./app"
import userRoute  from "/app/route/UserRoute"
const clubRoute = require("/app/route/ClubRoute")
const styleRoute = require("app/route/StyleRoute")
const matchRoute = require("app/route/MatchRoute")
const dotenv = require("dotenv")

dotenv.config({ path : "./.env" })

userRoute(app)
clubRoute(app)
styleRoute(app)
matchRoute(app)

app.listen(process.env.PORT)
