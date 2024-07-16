import { IconButton } from '@mui/material'
import { Favorite, FavoriteBorder } from '@mui/icons-material'
import { useState } from 'react'

function FavouriteButton() {
  const [liked, setLiked] = useState(false)

  function handleLike(event: React.MouseEvent<HTMLButtonElement, MouseEvent>) {
    event.stopPropagation()
    setLiked(!liked)
  }
  return (
    <IconButton onClick={handleLike} style={{ color: '#BF8C80' }}>
      {liked ? <Favorite style={{ color: '#BF8C80' }} /> : <FavoriteBorder />}
    </IconButton>
  )
}

export default FavouriteButton
