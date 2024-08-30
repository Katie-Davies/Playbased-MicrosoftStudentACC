import {
  Card,
  CardContent,
  CardMedia,
  Typography,
  CardActionArea,
} from '@mui/material'
import { styled } from '@mui/system'

import { useNavigate } from 'react-router-dom'

import FavouriteButton from './FavouriteButton'

// Custom styles using the styled utility
const CustomCard = styled(Card)(({ theme }) => ({
  border: '3px solid #BF8C80',
  maxWidth: 345,
  minWidth: 300,
  borderRadius: '20%',
}))

const CustomCardMedia = styled(CardMedia)<{ component: React.ElementType }>(
  ({ theme }) => ({
    border: '3px solid #588c7e',
    borderRadius: '20%',
    height: '200px',
    marginTop: '10px',
    width: '75%',
  })
)

const CustomTypography = styled(Typography)(({ theme }) => ({
  fontFamily: 'Sue Ellen Francisco, cursive',
  fontSize: '2rem',
  color: '#Bf8c80',
}))

interface SmallCardProps {
  key: number
  title: string

  imgurl: string
  id: number
}

function SmallCard(props: SmallCardProps) {
  const navigate = useNavigate()

  function handleClick() {
    navigate(`/activities/${props.id}`)
  }

  return (
    <div className="m-5">
      <CustomCard>
        <CardActionArea onClick={handleClick}>
          <div
            style={{
              display: 'flex',
              justifyContent: 'center',
              alignItems: 'center',
              height: '200px',
              marginTop: '20px',
            }}
          >
            <CustomCardMedia
              component="img"
              image={props.imgurl}
              alt={props.title}
              style={{ objectFit: 'cover', borderRadius: '8px' }}
            />
          </div>

          <CardContent>
            <div
              style={{
                display: 'flex',
                justifyContent: 'center',
                alignItems: 'center',
                height: 'auto',
              }}
            >
              <CustomTypography gutterBottom variant="h5">
                {props.title}
              </CustomTypography>

              <FavouriteButton activityId={props.id} userId={1} />
            </div>
          </CardContent>
        </CardActionArea>
      </CustomCard>
    </div>
  )
}

export default SmallCard
