import { Link, useLocation } from 'react-router-dom'
import logo from '../assets/Logo500x500.png'

function Nav() {
  const location = useLocation()
  return (
    <>
      <img src={logo} alt="logo" className="w-28 h-auto" />
      {location.pathname === '/activities' ? (
        <Link to="favourites">My Favourites </Link>
      ) : (
        <Link to="activities">Activities</Link>
      )}
    </>
  )
}

export default Nav
