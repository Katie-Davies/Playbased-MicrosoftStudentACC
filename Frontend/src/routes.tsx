import { createRoutesFromElements, Route } from 'react-router-dom'
import App from './pages/App'

// Named export of the routes
export const routes = createRoutesFromElements(
  <>
    <Route path="/" element={<App />}></Route>
  </>
)

// Default export of the named routes
export default routes
