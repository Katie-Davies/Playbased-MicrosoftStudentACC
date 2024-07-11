import { useState } from 'react'

import LogoPng from '../assets/Logo500x500.png'
import LogoJPG from '../assets/Logo500x500.jpg'
import viteLogo from '/vite.svg'

function App() {
  const [count, setCount] = useState(0)

  return (
    <>
      <div>
        <a href="https://vitejs.dev" target="_blank">
          <img src={viteLogo} className="logo" alt="Vite logo" />
        </a>
        <a href="https://react.dev" target="_blank">
          <img src={LogoPng} alt="logo png" className="w-24 h-auto" />
          <img src={LogoJPG} className="logo react" alt="logo jpg" />
        </a>
      </div>
      <h1>Vite + React</h1>
      <div className="card">
        <button onClick={() => setCount((count) => count + 1)}>
          count is {count}
        </button>
        <p>
          Edit <code>src/App.tsx</code> and save to test HMR
        </p>
      </div>
      <p className="text-4xl">
        Click on the Vite and React logos to learn more
      </p>
    </>
  )
}

export default App
