import { ReactNode } from 'react'

function Button(props: {
  onClick?: () => void
  className?: string
  children: ReactNode
}) {
  const { onClick, className = '', children } = props
  const defaultClassName = 'bg-customGreen text-white p-3 text-2xl rounded-full'
  return (
    <button className={`${defaultClassName} ${className}`} onClick={onClick}>
      {children}
    </button>
  )
}

export default Button
